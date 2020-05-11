using System;
using System.Collections.Generic;
using System.Text;

namespace 后重复
{
    class scale
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
            image.Dispose();
            System.GC.Collect();
            image = newImage;
        }
        public void rotate(int degrees)
        {
            RenderedOp newImage = ImageUtilities.getRotatedImage(
            image, degrees);
            image.Dispose();
            System.GC.Collect();
            image = newImage;
        }
    }

}
