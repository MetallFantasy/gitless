using System;
using System.Collections.Generic;
using System.Text;

namespace PinkBox {
    class Size {
        private int height; // Высота
        private int width; // Ширина
        private int length; // Длина

        public Size(int height, int width, int length)
        {
            if (height > 0 && height < 100)
            {
                this.height = height;
            }
            //else
            if (width > 0 && width < 100)
            {
                this.width = width;
            }
            //else
            if (length > 0 && length < 100)
            {
                this.length = length;
            }
            //else
        }
    }
}
