using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternExamples.Visitor.Acceptors;

namespace DesignPatternExamples.Visitor.Visitors {
	public interface IVisitor {
		int Count { get; set; }

		void Visit(BlisterPack blisterPack);

		void Visit(Bottle bottle);

		void Visit(Jar jar);
	}
}
