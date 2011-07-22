# BattleDotNet C# Wrapper

## Getting Started

Get realm statuses using strongly-typed methods

	WoWClient client = new WoWClient();
	IEnumerable<RealmStatus> result = client.GetRealmStatuses();

Get realm statuses using dynamic wrapper
	
	DynamicClient client = new DynamicClient("wow");
	IEnumerable<dynamic> result = client.Get("realm/status").realms;

## Requirements
* .NET 4.0 Client Profile

## Dependencies
* Json.NET (link: http://james.newtonking.com/projects/json-net.aspx)
** I made this decision to take Json.NET as a dependency due to it's speed and support for dynamics

## Q/A
Q: Why another?  
A: Why not?

Q: Why the requirement for .NET 4?  
A: I wanted to provide a more modern API with support for dynamics

Q: Will .NET 3.5 or lower be supported?  
A: If there's enough demand for it I will probably make a 3.5 build