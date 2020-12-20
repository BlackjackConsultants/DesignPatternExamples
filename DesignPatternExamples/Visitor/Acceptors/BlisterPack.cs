using DesignPatternExamples.Visitor.Visitors;

namespace DesignPatternExamples.Visitor.Acceptors {
	public class BlisterPack : IAcceptor {
		public int TabletPairs { get; set; }

		public void Accept(IVisitor visitor) {
			visitor.Visit(this);
		}
    }
}
