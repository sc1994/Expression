# Expression
解释 System.Linq.Expressions.Expression (表达式) 

#### 主要的项目结构参考了[ExpressionParser](http://www.cnblogs.com/blqw/p/3522677.html)项目思路

### 写在前面
- 主要目的是为了能够解释一个复杂的表达式树,将其拆解然后获取到表达式的各项属性,去组成自己想要的内容 : 如 lambda to sql,lambda to mongo
- 这是个重复的轮子, 比如我[参考的项目](http://www.cnblogs.com/blqw/p/3522677.html)
- 但是我希望这可以是个更好复用的项目

#### 一个表达式
```js
// Func<T1,T2>最后一个泛型是返回参数类型,其他都是输入参数类型
// x 指代输入参数 => 指代 ruturn
Expression<Func<Product, bool>> exp = 
x => x.Name == "1" && x.Id == 2 && (x.PriceInCents == 3 || x.Id == 4) || 
x.Name == "5" && x.Id == 6 && (x.PriceInCents == 7 || x.Id == 8);
```

#### Body
- => 后面的内容为 表达式的Body 返回 Expression 的实例
- 解释 Body 需要:
```js
if(exp.Body is BinaryExpression body){
    /**
    表达式看上去大概是这样的时候
        exp = x => x.a == 1;
        var a = 1;
        exp = x => x.a == a;
    主要属性有
        body.Left
        body.Right
        body.NodeType
    */
}
else if(exp.Body is MethodCallExpression body){
    /**
    表达式看上去大概是这样的时候
        var list = new [] {1,2,3,4,5};
        exp = x => list.Any(l => l == x.a);
    这个表示这段表达式包含方法调用
        body.Arguments 返回方法的各部分内容具体还需补充
        // todo
    */
}
else if......
```

