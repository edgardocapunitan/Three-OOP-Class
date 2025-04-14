using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LoveTriangle
{
public class Person
{
public string Name { get; set; }
public Person(string name)
{
Name = name;
}
public virtual void ShowLove()
{
Console.WriteLine(Name + &quot; is in a love triangle.&quot;);
}
}
public class Girl : Person
{
public Girl(string name) : base(name) { }
public override void ShowLove()
{
Console.WriteLine(Name + &quot; loves Vi.&quot;);
}
}
public class Boy : Person
{
public Boy(string name) : base(name) { }
public override void ShowLove()
{
Console.WriteLine(Name + &quot; loves Caithlyn.&quot;);
}
}
public class Bisexual : Person
{
public Bisexual(string name) : base(name) { }
public override void ShowLove()
{
Console.WriteLine(Name + &quot; loves Jayce.&quot;);
}
}
class Program
{
static void Main(string[] args)

{
Person caithlyn = new Girl(&quot;Caithlyn&quot;);
Person vi = new Bisexual(&quot;Vi&quot;);
Person jayce = new Boy(&quot;Jayce&quot;);
caithlyn.ShowLove();
vi.ShowLove();
jayce.ShowLove();
Console.ReadLine();
}
}
}