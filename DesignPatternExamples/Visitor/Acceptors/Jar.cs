using System;
using DesignPatternExamples.Visitor.Visitors;

namespace DesignPatternExamples.Visitor.Acceptors {
	public class Jar : IAcceptor {
		public int Pieces { get; set; }

		public void Accept(IVisitor visitor) {
			visitor.Visit(this);
		}
	}
}
