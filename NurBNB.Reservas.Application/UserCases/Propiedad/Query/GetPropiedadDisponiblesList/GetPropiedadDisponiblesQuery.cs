﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using NurBNB.Reservas.Application.Dto.Propiedad;
using NurBNB.Reservas.Domain.Model.Estados;

namespace NurBNB.Reservas.Application.UserCases.Propiedad.Query.GetPropiedadDisponiblesList
{
    public class GetPropiedadDisponiblesQuery : IRequest<ICollection<PropiedadDto>>
    {
        public TipoEstadoReserva estadoReserva { get; set; }
    }
}
