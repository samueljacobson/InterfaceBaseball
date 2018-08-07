using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballInterface
{
    public interface IBaseballBat   //interface private by default
    {
        int WeightInGrams { get; set; }
        void Swing();
    }
}
