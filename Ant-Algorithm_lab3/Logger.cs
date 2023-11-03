using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant_Algorithm_lab3
{
    class Logger
    {
        private MainForm form;
        public Logger(MainForm form)
        {
            this.form = form;
        }

        public void showLog(string log)
        {
            form.showLog(log);
        }

        public void addPoint(double x, double y)
        {
            form.addItemChart(x, y);
        }
    }
}
