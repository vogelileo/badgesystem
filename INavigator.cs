using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace YogaFemina2
{
    interface INavigator
    {
        void Navigate(Page nextPage, object state);

        void Navigat(Page nextpage);
    }
}
