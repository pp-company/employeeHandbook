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
```
4. 首尾重复
```
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
    3. 构造函数
<center> Copyright © 2020 珠海数镜空时科技有限公司 All Rights Reserved</center>