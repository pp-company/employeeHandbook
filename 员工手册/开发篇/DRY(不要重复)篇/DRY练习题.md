1. 类的变量重复(Clean Code第95页)     
```
public class Square {
 public Point topLeft;
 public double side;
}
public class Rectangle {
 public Point topLeft;
 public double height;
 public double width;
}
public class Circle {
 public Point center;
 public double radius;
}
public class Geometry {
 public final double PI = 3.141592653589793;
 public double area(Object shape) throws NoSuchShapeException
 {
 if (shape instanceof Square) {
 Square s = (Square)shape;
 return s.side * s.side;
 }
 else if (shape instanceof Rectangle) {
 Rectangle r = (Rectangle)shape;
 return r.height * r.width;
 }
 else if (shape instanceof Circle) {
 Circle c = (Circle)shape;
 return PI * c.radius * c.radius;
 }
 throw new NoSuchShapeException();
 }
}
```
2. 中重复
```
```
3. 后重复
```
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

```
4. 首尾重复
```

using System;
using System.Collections.Generic;
using System.Text;

namespace 中重复
{
    class HelloWorld
    {
        void Java()
        {
            Console.WriteLine("hello");
            Console.WriteLine("Java");
            Console.WriteLine("world");
        }
        void C()
        {
            Console.WriteLine("hello");
            Console.WriteLine("C");
            Console.WriteLine("world");
        }
        
    }
}

```
5. 到处都有重复
```
```
6. 什么样的重复看似重复实际不重复
    1. 碰巧相同看着都是写第一段，重复了，实际上不重复，因为实际写的第一段，填写的文字不是第一段，而是开头的第一段文字，每个文章的第一段都不一样
        ```
        public void 写短篇()
            {
                写("第一段");
            }
        ```
        ```
        public void 写第一段()
            {
                写("第一段");
            }
        ```
    2. 临时占位
        1. 例:throw new NotImplementedException(); 
        ```
        using System;
        namespace 后重复
        {
            internal class RenderedOp : IDisposable,IFormattable
            {
                public void Dispose()
                {
                    throw new NotImplementedException();  
                }

                public string ToString(string format, IFormatProvider formatProvider)
                {
                    throw new NotImplementedException(); 
                }
            }
        }
        ```
    3. 构造函数
        ```
        public _写动物园_(IEnumerable<会叫的> 动物们) : base(动物们)
            {
                _动物们 = 动物们;
            }
        ```
        ```
        public _读动物园_(IEnumerable<会叫的> 动物们) : base(动物们)
            {
                读();
            }
        ```
<center> Copyright © 2020 珠海数镜空时科技有限公司 All Rights Reserved</center>