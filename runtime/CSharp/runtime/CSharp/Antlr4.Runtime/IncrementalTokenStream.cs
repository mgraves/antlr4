using System;
using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime.Misc;

namespace Antlr4.Runtime
{
	public class IncrementalTokenStream : CommonTokenStream {
		/**
		 * ANTLR looks at the same tokens alot, and this avoids recalculating the
		 * interval when the position and lookahead number doesn't move.
		 */
		private int lastP = -1;
		private int lastK = -1;

		/**
		 * This tracks the min/max token index looked at since the value was reset. This
		 * is used to track how far ahead the grammar looked, since it may be outside
		 * the rule context's start/stop tokens. We need to maintain a stack of such
		 * indices.
		 */

		// MGMG C# Stacks don't have indexers -- can't set an item in the middle, so use List<> 
		private List<Interval> minMaxStack = new List<Interval>();

		/**
		 * Constructs a new {@link IncrementalTokenStream} using the specified token
		 * source and the default token channel ({@link Token#DEFAULT_CHANNEL}).
		 *
		 * @param tokenSource The token source.
		 */
		public IncrementalTokenStream(ITokenSource tokenSource) 
			: base(tokenSource) {
			// super(tokenSource);
		}

		/**
		 * Constructs a new {@link IncrementalTokenStream} using the specified token
		 * source and filtering tokens to the specified channel. Only tokens whose
		 * {@link Token#getChannel} matches {@code channel} or have the
		 * {@link Token#getType} equal to {@link Token#EOF} will be returned by the
		 * token stream lookahead methods.
		 *
		 * @param tokenSource The token source.
		 * @param channel     The channel to use for filtering tokens.
		 */
		public IncrementalTokenStream(ITokenSource tokenSource, int channel) 
			:base(tokenSource) {
			// this(tokenSource);
			this.channel = channel;
		}

		/**
		 * Push a new minimum/maximum token state.
		 *
		 * @param min Minimum token index
		 * @param max Maximum token index
		 */
		public void pushMinMax(int min, int max) {
			minMaxStack.Add(Interval.Of(min, max));
		}

		/**
		 * Pop the current minimum/maximum token state and return it.
		 */
		public Interval popMinMax() {
			if (minMaxStack.Count == 0) {
				throw new IndexOutOfRangeException("Can't pop the min max state when there are 0 states");
			}

			Interval lastInterval = this.minMaxStack[this.minMaxStack.Count - 1];
			minMaxStack.RemoveAt(this.minMaxStack.Count -1 );
			return lastInterval;
		}

		/**
		 * This is an override of the base LT function that tracks the minimum/maximum
		 * token index looked at.
		 */
		public override IToken LT(int k) {
			IToken result = base.LT(k);
			// Adjust the top of the minimum maximum stack if the position/lookahead amount
			// changed.
			if (minMaxStack.Count != 0 && (lastP != p || lastK != k)) {
				int lastIdx = minMaxStack.Count - 1;
				Interval stackItem = minMaxStack.ElementAt(lastIdx);
				minMaxStack[lastIdx] = stackItem.Union(Interval.Of(result.TokenIndex, result.TokenIndex));

				lastP = p;
				lastK = k;
			}
			return result;
		}
	}
}