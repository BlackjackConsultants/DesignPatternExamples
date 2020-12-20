using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternExamples.Visitor.Visitors;

namespace DesignPatternExamples.Visitor.Acceptors {
	public interface IAcceptor {
		void Accept(IVisitor visitor);
	}
}
