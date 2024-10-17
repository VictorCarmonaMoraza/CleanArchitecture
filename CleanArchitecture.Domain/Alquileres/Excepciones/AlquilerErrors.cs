using CleanArchitecture.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Alquileres.Excepciones;

public static class AlquilerErrors
{
    //Busco un alquiler con un status que no existe
    public static Error NotFound = new Error(
        "Alquiler no encontrado",
        "El alquiler con el Id especificado no fue encontrado"
        );

    //El alquiler ya fue confirmado
    public static Error Overlap = new Error(
        "Alquiler.Overlap",
        "El alquiler esta siendo tomado por 2 o mas clientes al mismo tiempo en la misma fecha"
        );

    public static Error NotReserved = new Error(
        "Alquiler.NotReserved",
        "El alquiler no esta reservado"
        );

    //NO confirmado
    public static Error NotConfirmed = new Error(
        "Alquiler.NotConfirmed",
        "El alquiler no esta confirmado"
        );

    //Alquiler cuando un aqluielr ya ha comenzado
    public static Error AlreadyStarted = new Error(
        "Alquiler.AlreadyStarted",
        "El alquiler ya ha comenzado"
        );
}
