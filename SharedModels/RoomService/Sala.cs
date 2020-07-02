using SharedModels;
using System;
using System.Collections.Generic;

public class Sala:EntityBase
{
    public int Id_Sala { get; set; }
    public string NombreSala { get; set; }
    public DateTime? FechaCreacion { get; set; }
    public DateTime? FechaBaja { get; set; }
    public DateTime? FechaUltimoUso { get; set; }
    public DateTime? TiempoAcumuladoUso { get; set; }
    public List<Participante> Participante { get; set; }
    public string PasswordSala { get; set; }
    public bool ControlAsistencia { get; set; }

}