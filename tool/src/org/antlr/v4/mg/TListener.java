// Generated from /Users/mike/dev/mg/antlr4/tool/src/org/antlr/v4/mg/T.g4 by ANTLR 4.8
package org.antlr.v4.mg;
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link TParser}.
 */
public interface TListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by the {@code alt1}
	 * labeled alternative in {@link TParser#a}.
	 * @param ctx the parse tree
	 */
	void enterAlt1(TParser.Alt1Context ctx);
	/**
	 * Exit a parse tree produced by the {@code alt1}
	 * labeled alternative in {@link TParser#a}.
	 * @param ctx the parse tree
	 */
	void exitAlt1(TParser.Alt1Context ctx);
	/**
	 * Enter a parse tree produced by the {@code alt2}
	 * labeled alternative in {@link TParser#a}.
	 * @param ctx the parse tree
	 */
	void enterAlt2(TParser.Alt2Context ctx);
	/**
	 * Exit a parse tree produced by the {@code alt2}
	 * labeled alternative in {@link TParser#a}.
	 * @param ctx the parse tree
	 */
	void exitAlt2(TParser.Alt2Context ctx);
	/**
	 * Enter a parse tree produced by {@link TParser#b}.
	 * @param ctx the parse tree
	 */
	void enterB(TParser.BContext ctx);
	/**
	 * Exit a parse tree produced by {@link TParser#b}.
	 * @param ctx the parse tree
	 */
	void exitB(TParser.BContext ctx);
	/**
	 * Enter a parse tree produced by {@link TParser#e}.
	 * @param ctx the parse tree
	 */
	void enterE(TParser.EContext ctx);
	/**
	 * Exit a parse tree produced by {@link TParser#e}.
	 * @param ctx the parse tree
	 */
	void exitE(TParser.EContext ctx);
}