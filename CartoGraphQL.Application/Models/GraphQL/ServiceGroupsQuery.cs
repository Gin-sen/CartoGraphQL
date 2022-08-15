using CartoGraphQL.Application.Models.CQRS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartoGraphQL.Application.Models.GraphQL
{
  public class ServiceGroupsQuery
  {
    readonly List<ServiceGroup> _serviceGroups = new()
    {
      new ServiceGroup(1, "chorus", new List<Service>()),
      new ServiceGroup(2, "renault", new List<Service>()),
      new ServiceGroup(3, "jupiter", new List<Service>())
    };
    public List<ServiceGroup> GetServiceGroups() => _serviceGroups;
  }
}
