using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursachBD
{
    public class PanelControl
    {
        public List<Panel> Panels { get; private set; }

        public PanelControl(List<Panel> panels)
        {
            Panels = panels;
        }
        public void HidePanels()
        {
            foreach (var panel in Panels)
            {
                panel.Hide();
            }
        }
    }
}
