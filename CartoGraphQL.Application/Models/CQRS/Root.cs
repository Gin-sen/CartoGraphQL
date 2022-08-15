using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CartoGraphQL.Application.Models.CQRS
{
  // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
  public record Environment(
int Id,
string Name,
Provider Provider
  );

  public record ExternalService(
int Id,
string Name,
Provider Provider,
string Url
  );

  public record Provider(
int Id,
string Name,
string Url
  );

  public record Root(
IReadOnlyList<Service> Service,
IReadOnlyList<ExternalService> ExternalServices,
IReadOnlyList<Environment> Environments,
IReadOnlyList<Webhook> Webhooks,
IReadOnlyList<Provider> Providers
  );

  public record Service(
int Id,
string Name,
ServiceGroup serviceGroup,
int MaintainerId,
IReadOnlyList<Webhook> Webhooks
  );

  public record ServiceGroup(
int Id,
string Name,
IReadOnlyList<Service?> Services
);

  public record Webhook(
int Id,
string Name,
string Url
  );


}
