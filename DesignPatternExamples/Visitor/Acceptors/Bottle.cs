using System;
using DesignPatternExamples.Visitor.Visitors;

namespace DesignPatternExamples.Visitor.Acceptors {
	public class Bottle: IAcceptor {
		public int Items { get; set; }

		public void Accept(IVisitor visitor) {
			visitor.Visit(this);
		}
	}
}
