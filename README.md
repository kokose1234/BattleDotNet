# BattleDotNet .NET Wrapper

The goal of this Battle.NET wrapper is to give .NET developers and modern API to interact with the Battle.NET API.  We try to abstract some of the oddities and mundane code out so you don't have to.

There is a dynamic API along with a staticly-typed one.  The reason for this is chances are the Battle.NET API will be ever-evolving during it's life.  Using the dynamic version gives a little more flexibility at the cost of losing intellisense and strongly-typed objects.

## Getting Started

### Examples

Get realm statuses using strongly-typed methods

	WoWClient client = new WoWClient();
	IEnumerable<RealmStatus> result = client.GetRealmStatuses();

Get realm statuses using dynamic wrapper
	
	DynamicClient client = new DynamicClient("wow");
	IEnumerable<dynamic> result = client.Get("realm/status").realms;

Get character info using dynamic wrapper

	DynamicClient client = new DynamicClient("wow");
	int achievementPoints = client.Get("character/shattered-hand/xtek").achievementPoints;

## Requirements
* .NET 4.0 Client Profile

## Dependencies
* Json.NET (link: http://james.newtonking.com/projects/json-net.aspx)
** I made this decision to take Json.NET as a dependency due to it's speed and support for dynamics

## Q/A
**Q: Why another wrapper?**  
A: Why not?

**Q: Why the requirement for .NET 4?**  
A: I wanted to provide a more modern API with support for dynamics

**Q: Will .NET 3.5 or lower be supported?**  
A: If there's enough demand for it I will probably make a 3.5 build

**Q: Will other platforms be supported like Silverlight, WP7, etc?**  
A: If there is enough demand, yes