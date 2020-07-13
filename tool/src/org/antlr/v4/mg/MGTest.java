package org.antlr.v4.mg;

import org.antlr.runtime.RecognitionException;
import org.antlr.v4.runtime.CharStreams;
import org.antlr.v4.runtime.CommonTokenStream;

import java.io.IOException;

public class MGTest {

	public static void main(String[] args) throws IOException, RecognitionException {
//		String content = new String ( Files.readAllBytes( Paths.get("T.g4") ) );
//    	LexerGrammar lexerGrammar = new LexerGrammar(content);
//
//    	System.out.println("done");

		TLexer tLexer = new TLexer(CharStreams.fromString("b"));
		CommonTokenStream tokens = new CommonTokenStream(tLexer);

		TParser tParser = new TParser(tokens);
		tParser.a();

		System.out.println("done");
/*
        TParser parser = new TParser(new CommonTokenStream(new TLexer(new ANTLRInputStream("b"))));
        parser.addParseListener(new MyTBaseListener());

		parser.a();

		System.out.println("######################");
		parser = new TParser(new CommonTokenStream(new TLexer(new org.antlr.v4.runtime.ANTLRInputStream("x"))));
		parser.addParseListener(new MyTBaseListener());
		parser.b();
*/
    }

}
