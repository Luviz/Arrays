using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays {
	public interface IStack <T> {
        T Pop();
        void Push(T item);
        T Peek();
	}
}
