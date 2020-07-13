using System;
using Antlr4.Runtime.Misc;

namespace Antlr4.Runtime
{
    public class IncrementalParserRuleContext : ParserRuleContext {
    /* Avoid having to recompute depth on every single depth call */
    private int cachedDepth;
    private RuleContext cachedParent;

    // This is an epoch number that can be used to tell which pieces were
    // modified during a given incremental parse. The incremental parser
    // adds the current epoch number to all rule contexts it creates.
    // The epoch number is incremented every time a new parser instance is created.
    private int _epoch = -1;

    public int epoch {
        get;
        set;
    }
    
    // public int getEpoch() { return this.epoch; }
    // public void setEpoch(int value) {
    //     this.epoch = value;
    // }
    // The interval that stores the min/max token we touched during
    // lookahead/lookbehind
    private Interval _minMaxTokenIndex = Interval.Of(Int32.MaxValue, Int32.MinValue);

    /**
	 * Get the minimum token index this rule touched.
	 */
    public int MinTokenIndex => _minMaxTokenIndex.a;

    /**
	 * Get the maximum token index this rule touched.
	 */
    public int MaxTokenIndex => _minMaxTokenIndex.b;
    

    /**
	 * Get the interval this rule touched.
	 */
    public Interval getMinMaxTokenIndex() {
        return _minMaxTokenIndex;
    }

    public void setMinMaxTokenIndex(Interval index) {
        _minMaxTokenIndex = index;
    }

    /**
	 * Compute the depth of this context in the parse tree.
	 *
	 * @note The incremental parser uses a caching implemntation.
	 *
	 */
    public override int Depth() {
        if (cachedParent != null && cachedParent == this.Parent) {
            return cachedDepth;
        }
        int n = 1;
        if (this.Parent != null) {
            int parentDepth = this.Parent.Depth();
            this.cachedParent = this.Parent;
            this.cachedDepth = n = parentDepth + 1;
        } else {
            this.cachedDepth = n = 1;
        }
        return n;
    }

    public IncrementalParserRuleContext() {
    }

    public IncrementalParserRuleContext(IncrementalParserRuleContext parent, int invokingStateNumber) 
    : base(parent, invokingStateNumber){
        // super(parent, invokingStateNumber);
    }
    }
}