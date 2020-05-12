2. 中重复
```
```
3. [后重复](代码/后重复)
```
using System;
using System.Collections.Generic;
using System.Text;

namespace 后重复
{
    class GoodScale
    {
        private float errorThreshold;
        private RenderedOp image;

        public void scaleToOneDimension(float desiredDimension, float imageDimension)
        {
            if (Math.Abs(desiredDimension - imageDimension) < errorThreshold)
                return;
            float scalingFactor = desiredDimension / imageDimension;
            scalingFactor = (float)(Math.Floor(scalingFactor * 100) * 0.01f);
            RenderedOp newImage = ImageUtilities.getScaledImage(
            image, scalingFactor, scalingFactor);
            replaceImage(newImage);
        }
        public void rotate(int degrees)
        {
            RenderedOp newImage = ImageUtilities.getRotatedImage(
            image, degrees);
            replaceImage(newImage);
        }

        private void replaceImage(RenderedOp newImage)
        {
            image.Dispose();
            System.GC.Collect();
            image = newImage;
        }
    }
}
```
<center> Copyright © 2020 珠海数镜空时科技有限公司 All Rights Reserved</center>