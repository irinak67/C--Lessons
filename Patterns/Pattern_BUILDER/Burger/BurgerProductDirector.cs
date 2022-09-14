using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_BUILDER.Burger
{
    public class BurgerProductDirector
    {
        public readonly IBurgerProductBuilder _builder;
        public BurgerProductDirector(IBurgerProductBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder
                .BuildTop()
                .BuildFilling()
                .BuildBase();
        }
    }
}
