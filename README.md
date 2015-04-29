# scalesque fork
## A Scala inspired functional programming library written in c&#35;

Along with the below, this fork deviates from Scala in that Option no longer has a Get (Match/GetOrElse are preferred). 
It also adds a number of helper methods for easier usage and enhances equality checking of Option
I also removed .NET 3.5 as I did not need it. It is still there, just not included and out of date.

Scalesque allows you to write c&#35; that is similar to the code you would write in Scala.  Scalesque is currently approaching v1, it's pretty stable but some api calls may still change.  

### Features list

* Option&lt;T&gt; (aka Maybe&lt;T&gt;)
* Either&lt;T,U&gt;
* Pattern matching and extraction
* Map / Fold / Reduce (via IEnumerable&lt;T&gt;)
* Partial function application and currying
* Scalaz inspired validations
* Exception -> Option wrapper

## Dependencies

.net 4.0

## License

scalesque is licensed under the MIT license, see license.txt for details.

## Nuget package

Usually in synch with head of master

## Roadmap
* I'm working on the [Documentation](http://noelkennedy.github.com/scalesque)
* Extractors for .net framework patterns like Int.TryParse which are a bit horrible from a functional programming perspective
* Not happy with current Head and tail construct

