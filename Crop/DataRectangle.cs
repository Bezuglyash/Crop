using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crop
{
    class ДанныеПрямоугольника
    {
        private const int ШИРИНА = 28;
        private const int ВЫСОТА = 28;
        private const int КООРДИНАТА_Y = 328;
        private int координатаX;

        public ДанныеПрямоугольника(int координатаX)
        {
            this.координатаX = координатаX;
        }

        public int ПередатьШИРИНУ()
        {
            return ШИРИНА;
        }
        public int ПередатьВЫСОТУ()
        {
            return ВЫСОТА;
        }

        public int ПередатьКООРДИНАТУ_Y()
        {
            return КООРДИНАТА_Y;
        }

        public int ПередатьКоординатуX()
        {
            return координатаX;
        }

        public void ИзменитьКоординатуX(int число)
        {
            координатаX -= число;
        }
    }
}
