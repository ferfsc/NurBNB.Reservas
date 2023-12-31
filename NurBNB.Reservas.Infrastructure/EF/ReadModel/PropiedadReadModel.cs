﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NurBNB.Reservas.Infrastructure.EF.ReadModel
{
    [ExcludeFromCodeCoverage]
    [Table("propiedad")]
    internal class PropiedadReadModel
    {
	   [Key]
	   [Column("ID_Propiedad")]
	   public Guid Id { get; set; }

	   [Column("Propietario_ID")]
	   [Required]
	   public string Propietario_ID { get; set; }

	   [Column("titulo")]
	   [StringLength(100)]
	   [Required]
	   public string Titulo { get; set; }

	   [Column("precio", TypeName = "decimal(18,2)")]
	   [Required]
	   public decimal Precio { get; set; }

	   [Column("detalle")]
	   [StringLength(300)]
	   [Required]
	   public string Detalle { get; set; }

	   [Column("ubicacion")]
	   [StringLength(150)]
	   [Required]
	   public string Ubicacion { get; set; }

	   [Column("estado")]
	   [Required]
	   public string Estado { get; set; }

    }
}
