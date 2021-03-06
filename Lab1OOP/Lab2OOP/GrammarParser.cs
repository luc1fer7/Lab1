//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from .\Grammar.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class GrammarParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		LEFT_BRACKET=1, RIGHT_BRACKET=2, CELL_EXPRESSION=3, COLUMN_EXPRESSION=4, 
		IN_POWER=5, MULTIPLICATION_SIGN=6, DIVISION_SIGN=7, PLUS_SIGN=8, MINUS_SIGN=9, 
		ON_MODULO=10, DIV=11, NUMBER_EXPRESSION=12, MAX_EXPRESSION=13, MIN_EXPRESSION=14, 
		COMMA=15, WHITESPACE_EXPRESSION=16, WRONG_EXPRESSION=17;
	public const int
		RULE_rule = 0, RULE_expression = 1;
	public static readonly string[] ruleNames = {
		"rule", "expression"
	};

	private static readonly string[] _LiteralNames = {
		null, "'('", "')'", null, null, "'^'", "'*'", "'/'", "'+'", "'-'", "' mod '", 
		"' div '", null, "'mmax'", "'mmin'", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LEFT_BRACKET", "RIGHT_BRACKET", "CELL_EXPRESSION", "COLUMN_EXPRESSION", 
		"IN_POWER", "MULTIPLICATION_SIGN", "DIVISION_SIGN", "PLUS_SIGN", "MINUS_SIGN", 
		"ON_MODULO", "DIV", "NUMBER_EXPRESSION", "MAX_EXPRESSION", "MIN_EXPRESSION", 
		"COMMA", "WHITESPACE_EXPRESSION", "WRONG_EXPRESSION"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Grammar.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static GrammarParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public GrammarParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public GrammarParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class RuleContext : ParserRuleContext {
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(GrammarParser.Eof, 0); }
		public RuleContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_rule; } }
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterRule(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitRule(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGrammarVisitor<TResult> typedVisitor = visitor as IGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRule(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public RuleContext rule() {
		RuleContext _localctx = new RuleContext(Context, State);
		EnterRule(_localctx, 0, RULE_rule);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 4; expression(0);
			State = 5; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpressionContext : ParserRuleContext {
		public ExpressionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expression; } }
	 
		public ExpressionContext() { }
		public virtual void CopyFrom(ExpressionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class MaxOfContext : ExpressionContext {
		public ITerminalNode MAX_EXPRESSION() { return GetToken(GrammarParser.MAX_EXPRESSION, 0); }
		public ITerminalNode LEFT_BRACKET() { return GetToken(GrammarParser.LEFT_BRACKET, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode RIGHT_BRACKET() { return GetToken(GrammarParser.RIGHT_BRACKET, 0); }
		public ITerminalNode[] COMMA() { return GetTokens(GrammarParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(GrammarParser.COMMA, i);
		}
		public MaxOfContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterMaxOf(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitMaxOf(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGrammarVisitor<TResult> typedVisitor = visitor as IGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMaxOf(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NegativeNumberContext : ExpressionContext {
		public ITerminalNode MINUS_SIGN() { return GetToken(GrammarParser.MINUS_SIGN, 0); }
		public ITerminalNode NUMBER_EXPRESSION() { return GetToken(GrammarParser.NUMBER_EXPRESSION, 0); }
		public NegativeNumberContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterNegativeNumber(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitNegativeNumber(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGrammarVisitor<TResult> typedVisitor = visitor as IGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNegativeNumber(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class WrongContext : ExpressionContext {
		public ITerminalNode WRONG_EXPRESSION() { return GetToken(GrammarParser.WRONG_EXPRESSION, 0); }
		public WrongContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterWrong(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitWrong(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGrammarVisitor<TResult> typedVisitor = visitor as IGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitWrong(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NumberContext : ExpressionContext {
		public ITerminalNode NUMBER_EXPRESSION() { return GetToken(GrammarParser.NUMBER_EXPRESSION, 0); }
		public NumberContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterNumber(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitNumber(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGrammarVisitor<TResult> typedVisitor = visitor as IGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumber(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AdditionSubtractionContext : ExpressionContext {
		public IToken operation;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode MINUS_SIGN() { return GetToken(GrammarParser.MINUS_SIGN, 0); }
		public ITerminalNode PLUS_SIGN() { return GetToken(GrammarParser.PLUS_SIGN, 0); }
		public AdditionSubtractionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterAdditionSubtraction(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitAdditionSubtraction(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGrammarVisitor<TResult> typedVisitor = visitor as IGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAdditionSubtraction(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MinOfContext : ExpressionContext {
		public ITerminalNode MIN_EXPRESSION() { return GetToken(GrammarParser.MIN_EXPRESSION, 0); }
		public ITerminalNode LEFT_BRACKET() { return GetToken(GrammarParser.LEFT_BRACKET, 0); }
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode RIGHT_BRACKET() { return GetToken(GrammarParser.RIGHT_BRACKET, 0); }
		public ITerminalNode[] COMMA() { return GetTokens(GrammarParser.COMMA); }
		public ITerminalNode COMMA(int i) {
			return GetToken(GrammarParser.COMMA, i);
		}
		public MinOfContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterMinOf(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitMinOf(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGrammarVisitor<TResult> typedVisitor = visitor as IGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMinOf(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class InPowerContext : ExpressionContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode IN_POWER() { return GetToken(GrammarParser.IN_POWER, 0); }
		public InPowerContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterInPower(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitInPower(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGrammarVisitor<TResult> typedVisitor = visitor as IGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInPower(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class InBracketsContext : ExpressionContext {
		public ITerminalNode LEFT_BRACKET() { return GetToken(GrammarParser.LEFT_BRACKET, 0); }
		public ExpressionContext expression() {
			return GetRuleContext<ExpressionContext>(0);
		}
		public ITerminalNode RIGHT_BRACKET() { return GetToken(GrammarParser.RIGHT_BRACKET, 0); }
		public InBracketsContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterInBrackets(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitInBrackets(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGrammarVisitor<TResult> typedVisitor = visitor as IGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInBrackets(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class MultiplicationDivisionContext : ExpressionContext {
		public IToken operation;
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode MULTIPLICATION_SIGN() { return GetToken(GrammarParser.MULTIPLICATION_SIGN, 0); }
		public ITerminalNode DIVISION_SIGN() { return GetToken(GrammarParser.DIVISION_SIGN, 0); }
		public MultiplicationDivisionContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterMultiplicationDivision(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitMultiplicationDivision(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGrammarVisitor<TResult> typedVisitor = visitor as IGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMultiplicationDivision(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class CellContext : ExpressionContext {
		public ITerminalNode CELL_EXPRESSION() { return GetToken(GrammarParser.CELL_EXPRESSION, 0); }
		public CellContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterCell(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitCell(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGrammarVisitor<TResult> typedVisitor = visitor as IGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCell(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class OnDivContext : ExpressionContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode DIV() { return GetToken(GrammarParser.DIV, 0); }
		public OnDivContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterOnDiv(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitOnDiv(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGrammarVisitor<TResult> typedVisitor = visitor as IGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOnDiv(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class OnModuloContext : ExpressionContext {
		public ExpressionContext[] expression() {
			return GetRuleContexts<ExpressionContext>();
		}
		public ExpressionContext expression(int i) {
			return GetRuleContext<ExpressionContext>(i);
		}
		public ITerminalNode ON_MODULO() { return GetToken(GrammarParser.ON_MODULO, 0); }
		public OnModuloContext(ExpressionContext context) { CopyFrom(context); }
		public override void EnterRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.EnterOnModulo(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IGrammarListener typedListener = listener as IGrammarListener;
			if (typedListener != null) typedListener.ExitOnModulo(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGrammarVisitor<TResult> typedVisitor = visitor as IGrammarVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOnModulo(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpressionContext expression() {
		return expression(0);
	}

	private ExpressionContext expression(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExpressionContext _localctx = new ExpressionContext(Context, _parentState);
		ExpressionContext _prevctx = _localctx;
		int _startState = 2;
		EnterRecursionRule(_localctx, 2, RULE_expression, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 41;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case MINUS_SIGN:
				{
				_localctx = new NegativeNumberContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 8; Match(MINUS_SIGN);
				State = 9; Match(NUMBER_EXPRESSION);
				}
				break;
			case LEFT_BRACKET:
				{
				_localctx = new InBracketsContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 10; Match(LEFT_BRACKET);
				State = 11; expression(0);
				State = 12; Match(RIGHT_BRACKET);
				}
				break;
			case MIN_EXPRESSION:
				{
				_localctx = new MinOfContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 14; Match(MIN_EXPRESSION);
				State = 15; Match(LEFT_BRACKET);
				State = 19;
				ErrorHandler.Sync(this);
				_alt = 1;
				do {
					switch (_alt) {
					case 1:
						{
						{
						State = 16; expression(0);
						State = 17; Match(COMMA);
						}
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					State = 21;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,0,Context);
				} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
				State = 23; expression(0);
				State = 24; Match(RIGHT_BRACKET);
				}
				break;
			case MAX_EXPRESSION:
				{
				_localctx = new MaxOfContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 26; Match(MAX_EXPRESSION);
				State = 27; Match(LEFT_BRACKET);
				State = 31;
				ErrorHandler.Sync(this);
				_alt = 1;
				do {
					switch (_alt) {
					case 1:
						{
						{
						State = 28; expression(0);
						State = 29; Match(COMMA);
						}
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					State = 33;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,1,Context);
				} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
				State = 35; expression(0);
				State = 36; Match(RIGHT_BRACKET);
				}
				break;
			case NUMBER_EXPRESSION:
				{
				_localctx = new NumberContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 38; Match(NUMBER_EXPRESSION);
				}
				break;
			case CELL_EXPRESSION:
				{
				_localctx = new CellContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 39; Match(CELL_EXPRESSION);
				}
				break;
			case WRONG_EXPRESSION:
				{
				_localctx = new WrongContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 40; Match(WRONG_EXPRESSION);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			Context.Stop = TokenStream.LT(-1);
			State = 60;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 58;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
					case 1:
						{
						_localctx = new InPowerContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 43;
						if (!(Precpred(Context, 10))) throw new FailedPredicateException(this, "Precpred(Context, 10)");
						State = 44; Match(IN_POWER);
						State = 45; expression(11);
						}
						break;
					case 2:
						{
						_localctx = new MultiplicationDivisionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 46;
						if (!(Precpred(Context, 9))) throw new FailedPredicateException(this, "Precpred(Context, 9)");
						State = 47;
						((MultiplicationDivisionContext)_localctx).operation = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==MULTIPLICATION_SIGN || _la==DIVISION_SIGN) ) {
							((MultiplicationDivisionContext)_localctx).operation = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 48; expression(10);
						}
						break;
					case 3:
						{
						_localctx = new AdditionSubtractionContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 49;
						if (!(Precpred(Context, 8))) throw new FailedPredicateException(this, "Precpred(Context, 8)");
						State = 50;
						((AdditionSubtractionContext)_localctx).operation = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==PLUS_SIGN || _la==MINUS_SIGN) ) {
							((AdditionSubtractionContext)_localctx).operation = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 51; expression(9);
						}
						break;
					case 4:
						{
						_localctx = new OnModuloContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 52;
						if (!(Precpred(Context, 7))) throw new FailedPredicateException(this, "Precpred(Context, 7)");
						State = 53; Match(ON_MODULO);
						State = 54; expression(8);
						}
						break;
					case 5:
						{
						_localctx = new OnDivContext(new ExpressionContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expression);
						State = 55;
						if (!(Precpred(Context, 6))) throw new FailedPredicateException(this, "Precpred(Context, 6)");
						State = 56; Match(DIV);
						State = 57; expression(7);
						}
						break;
					}
					} 
				}
				State = 62;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

    public override bool Sempred(Antlr4.Runtime.RuleContext _localctx, int ruleIndex, int actionIndex)
    {
        switch (ruleIndex)
        {
            case 1: return expression_sempred((ExpressionContext)_localctx, actionIndex);
        }
        return true;
    }

	private bool expression_sempred(ExpressionContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 10);
		case 1: return Precpred(Context, 9);
		case 2: return Precpred(Context, 8);
		case 3: return Precpred(Context, 7);
		case 4: return Precpred(Context, 6);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x13', '\x42', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x6', '\x3', '\x16', '\n', '\x3', '\r', '\x3', '\xE', '\x3', '\x17', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x6', '\x3', '\"', '\n', '\x3', 
		'\r', '\x3', '\xE', '\x3', '#', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x5', '\x3', ',', '\n', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\a', '\x3', '=', '\n', '\x3', '\f', '\x3', '\xE', '\x3', '@', '\v', '\x3', 
		'\x3', '\x3', '\x2', '\x3', '\x4', '\x4', '\x2', '\x4', '\x2', '\x4', 
		'\x3', '\x2', '\b', '\t', '\x3', '\x2', '\n', '\v', '\x2', 'L', '\x2', 
		'\x6', '\x3', '\x2', '\x2', '\x2', '\x4', '+', '\x3', '\x2', '\x2', '\x2', 
		'\x6', '\a', '\x5', '\x4', '\x3', '\x2', '\a', '\b', '\a', '\x2', '\x2', 
		'\x3', '\b', '\x3', '\x3', '\x2', '\x2', '\x2', '\t', '\n', '\b', '\x3', 
		'\x1', '\x2', '\n', '\v', '\a', '\v', '\x2', '\x2', '\v', ',', '\a', '\xE', 
		'\x2', '\x2', '\f', '\r', '\a', '\x3', '\x2', '\x2', '\r', '\xE', '\x5', 
		'\x4', '\x3', '\x2', '\xE', '\xF', '\a', '\x4', '\x2', '\x2', '\xF', ',', 
		'\x3', '\x2', '\x2', '\x2', '\x10', '\x11', '\a', '\x10', '\x2', '\x2', 
		'\x11', '\x15', '\a', '\x3', '\x2', '\x2', '\x12', '\x13', '\x5', '\x4', 
		'\x3', '\x2', '\x13', '\x14', '\a', '\x11', '\x2', '\x2', '\x14', '\x16', 
		'\x3', '\x2', '\x2', '\x2', '\x15', '\x12', '\x3', '\x2', '\x2', '\x2', 
		'\x16', '\x17', '\x3', '\x2', '\x2', '\x2', '\x17', '\x15', '\x3', '\x2', 
		'\x2', '\x2', '\x17', '\x18', '\x3', '\x2', '\x2', '\x2', '\x18', '\x19', 
		'\x3', '\x2', '\x2', '\x2', '\x19', '\x1A', '\x5', '\x4', '\x3', '\x2', 
		'\x1A', '\x1B', '\a', '\x4', '\x2', '\x2', '\x1B', ',', '\x3', '\x2', 
		'\x2', '\x2', '\x1C', '\x1D', '\a', '\xF', '\x2', '\x2', '\x1D', '!', 
		'\a', '\x3', '\x2', '\x2', '\x1E', '\x1F', '\x5', '\x4', '\x3', '\x2', 
		'\x1F', ' ', '\a', '\x11', '\x2', '\x2', ' ', '\"', '\x3', '\x2', '\x2', 
		'\x2', '!', '\x1E', '\x3', '\x2', '\x2', '\x2', '\"', '#', '\x3', '\x2', 
		'\x2', '\x2', '#', '!', '\x3', '\x2', '\x2', '\x2', '#', '$', '\x3', '\x2', 
		'\x2', '\x2', '$', '%', '\x3', '\x2', '\x2', '\x2', '%', '&', '\x5', '\x4', 
		'\x3', '\x2', '&', '\'', '\a', '\x4', '\x2', '\x2', '\'', ',', '\x3', 
		'\x2', '\x2', '\x2', '(', ',', '\a', '\xE', '\x2', '\x2', ')', ',', '\a', 
		'\x5', '\x2', '\x2', '*', ',', '\a', '\x13', '\x2', '\x2', '+', '\t', 
		'\x3', '\x2', '\x2', '\x2', '+', '\f', '\x3', '\x2', '\x2', '\x2', '+', 
		'\x10', '\x3', '\x2', '\x2', '\x2', '+', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', '+', '(', '\x3', '\x2', '\x2', '\x2', '+', ')', '\x3', '\x2', '\x2', 
		'\x2', '+', '*', '\x3', '\x2', '\x2', '\x2', ',', '>', '\x3', '\x2', '\x2', 
		'\x2', '-', '.', '\f', '\f', '\x2', '\x2', '.', '/', '\a', '\a', '\x2', 
		'\x2', '/', '=', '\x5', '\x4', '\x3', '\r', '\x30', '\x31', '\f', '\v', 
		'\x2', '\x2', '\x31', '\x32', '\t', '\x2', '\x2', '\x2', '\x32', '=', 
		'\x5', '\x4', '\x3', '\f', '\x33', '\x34', '\f', '\n', '\x2', '\x2', '\x34', 
		'\x35', '\t', '\x3', '\x2', '\x2', '\x35', '=', '\x5', '\x4', '\x3', '\v', 
		'\x36', '\x37', '\f', '\t', '\x2', '\x2', '\x37', '\x38', '\a', '\f', 
		'\x2', '\x2', '\x38', '=', '\x5', '\x4', '\x3', '\n', '\x39', ':', '\f', 
		'\b', '\x2', '\x2', ':', ';', '\a', '\r', '\x2', '\x2', ';', '=', '\x5', 
		'\x4', '\x3', '\t', '<', '-', '\x3', '\x2', '\x2', '\x2', '<', '\x30', 
		'\x3', '\x2', '\x2', '\x2', '<', '\x33', '\x3', '\x2', '\x2', '\x2', '<', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '<', '\x39', '\x3', '\x2', '\x2', 
		'\x2', '=', '@', '\x3', '\x2', '\x2', '\x2', '>', '<', '\x3', '\x2', '\x2', 
		'\x2', '>', '?', '\x3', '\x2', '\x2', '\x2', '?', '\x5', '\x3', '\x2', 
		'\x2', '\x2', '@', '>', '\x3', '\x2', '\x2', '\x2', '\a', '\x17', '#', 
		'+', '<', '>',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
