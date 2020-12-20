using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternExamples.Visitor.Acceptors;

namespace DesignPatternExamples.Visitor.Visitors {
	public class PillCountVisitor : IVisitor {
		public int Count { get; set; }

		public void Visit(BlisterPack blisterPack) {
			Count += blisterPack.TabletPairs * 2;
		}

		public void Visit(Bottle bottle) {
			Count += bottle.Items;
		}

		public void Visit(Jar jar) {
			Count += jar.Pieces;
		}
	}
}
