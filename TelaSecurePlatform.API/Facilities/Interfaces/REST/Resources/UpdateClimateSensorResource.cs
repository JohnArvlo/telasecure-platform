﻿using TelaSecurePlatform.API.Facilities.Domain.Model.ValueObjects;

namespace TelaSecurePlatform.API.Facilities.Interfaces.REST.Resources;

public record UpdateClimateSensorResource(string Name, string Model, EClimateSensorType Type, string Image, string WarehouseId);