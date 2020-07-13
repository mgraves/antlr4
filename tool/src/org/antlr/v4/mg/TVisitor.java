// Generated from /Users/mike/dev/mg/antlr4/tool/src/org/antlr/v4/mg/T.g4 by ANTLR 4.8
package org.antlr.v4.mg;
import org.antlr.v4.runtime.tree.ParseTreeVisitor;

/**
 * This interface defines a complete generic visitor for a parse tree produced
 * by {@link TParser}.
 *
 * @param <T> The return type of the visit operation. Use {@link Void} for
 * operations with no return type.
 */
public interface TVisitor<T> extends ParseTreeVisitor<T> {
	/**
	 * Visit a parse tree produced by the {@code alt1}
	 * labeled alternative in {@link TParser#a}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAlt1(TParser.Alt1Context ctx);
	/**
	 * Visit a parse tree produced by the {@code alt2}
	 * labeled alternative in {@link TParser#a}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitAlt2(TParser.Alt2Context ctx);
	/**
	 * Visit a parse tree produced by {@link TParser#b}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitB(TParser.BContext ctx);
	/**
	 * Visit a parse tree produced by {@link TParser#e}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitE(TParser.EContext ctx);
}