# Expression
解释 System.Linq.Expressions.Expression (表达式) 

#### 主要的项目结构参考了[ExpressionParser](http://www.cnblogs.com/blqw/p/3522677.html)项目思路

### 写在前面
- 主要目的是为了能够解释一个复杂的表达式树,将其拆解然后获取到表达式的各项属性,去组成自己想要的内容 : 如 lambda to sql,lambda to mongo
- 这是个重复的轮子, 比如我[参考的项目](http://www.cnblogs.com/blqw/p/3522677.html)
- 但是我希望这可以是个更好复用的项目

#### 短板
- 
#### 一个表达式
```js
// Func<T1,T2>最后一个泛型是返回参数类型,其他都是输入参数类型
// x 指代输入参数 => 指代 ruturn
Expression<Func<Product, bool>> exp = 
x => x.Name == "1" && x.Id == 2 && (x.PriceInCents == 3 || x.Id == 4) || 
x.Name == "5" && x.Id == 6 && (x.PriceInCents == 7 || x.Id == 8);
```

#### TODO


#### 目标
- 将表达式树拆解成最小状态的表达式
- [x]  支持 System.Linq.Expressions.BinaryExpression
- [ ]  支持 System.Linq.Expressions.BlockExpression
- [ ]  支持 System.Linq.Expressions.ConditionalExpression
- [x]  支持 System.Linq.Expressions.ConstantExpression
- [ ]  支持 System.Linq.Expressions.DebugInfoExpression
- [ ]  支持 System.Linq.Expressions.DefaultExpression
- [ ]  支持 System.Linq.Expressions.DynamicExpression
- [ ]  支持 System.Linq.Expressions.GotoExpression
- [ ]  支持 System.Linq.Expressions.IndexExpression
- [ ]  支持 System.Linq.Expressions.InvocationExpression
- [ ]  支持 System.Linq.Expressions.LabelExpression
- [x]  支持 System.Linq.Expressions.LambdaExpression
- [ ]  支持 System.Linq.Expressions.ListInitExpression
- [ ]  支持 System.Linq.Expressions.LoopExpression
- [x]  支持 System.Linq.Expressions.MemberExpression
- [ ]  支持 System.Linq.Expressions.MemberInitExpression
- [x]  支持 System.Linq.Expressions.MethodCallExpression
- [x]  支持 System.Linq.Expressions.NewArrayExpression
- [ ]  支持 System.Linq.Expressions.NewExpression
- [x]  支持 System.Linq.Expressions.ParameterExpression
- [ ]  支持 System.Linq.Expressions.RuntimeVariablesExpression
- [ ]  支持 System.Linq.Expressions.SwitchExpression
- [ ]  支持 System.Linq.Expressions.TryExpression
- [ ]  支持 System.Linq.Expressions.TypeBinaryExpression
- [x]  支持 System.Linq.Expressions.UnaryExpression
#### 支持Sql
- [ ]  AddShow
- [ ]  AddWhere
- [ ]  IN
- [ ]  LIKE
- [ ]  AddJoin
- [ ]  AddOrder
- [ ]  PageConfig
- [ ]  AddGroup
- [ ]  Having
- [ ]  Top
- [ ]  Count
