﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NurBNB.Reservas.Application.Dto.Huesped;
using NurBNB.Reservas.Application.Dto.Propiedad;
using NurBNB.Reservas.Application.UserCases.Propiedad.Query.GetPropiedadDisponiblesList;
using NurBNB.Reservas.Infrastructure.EF.Context;
using NurBNB.Reservas.Infrastructure.EF.ReadModel;

namespace NurBNB.Reservas.Infrastructure.UseCases.Propiedad.Query
{
    internal class GetPropiedadListHandler : IRequestHandler<GetPropiedadDisponiblesQuery, ICollection<PropiedadDto>>
    {
        private readonly DbSet<PropiedadReadModel> _propiedades;

        public GetPropiedadListHandler(ReadDbContext context)
        {
            _propiedades = context.Propiedad;
        }


        public async Task<ICollection<PropiedadDto>> Handle(GetPropiedadDisponiblesQuery request, CancellationToken cancellationToken)
        {
            var query = _propiedades.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(Convert.ToString( request.estadoReserva)))
            {
                query = query.Where(x => x.Estado == request.estadoReserva.ToString());
            }

            return await query.Select(propiedad =>
                new PropiedadDto
                {
                    PropiedadID = propiedad.Id,
                    ID_Propietario = propiedad.ID_Propietario,
                    Titulo = propiedad.Titulo,
                    Detalle = propiedad.Detalle,
                    Precio = propiedad.Precio,
                    ubicacion = propiedad.Ubicacion,
                    Estado = propiedad.Estado
                   

                }).ToListAsync(cancellationToken);
        }
    }
}
