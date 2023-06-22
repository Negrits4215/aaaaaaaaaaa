using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Dapper;
using PF.API.Models;

namespace PF.API.Utils;
    
    public static class BDPF {
        private static string CONNECTION_STRING=@"Server=DESKTOP-NAREAUV    ;Database=ProyectoFinal;Trusted_Connection=True;";

        public static List<Temas> GetTemas() {
            string sqlQuery;
            List<Temas> returnList;
            returnList=new List<Temas>();

            using (SqlConnection db=new SqlConnection(CONNECTION_STRING)) {
                sqlQuery="SELECT * FROM Temas";
                returnList=db.Query<Temas>(sqlQuery).ToList();
            }

            return returnList;
        }
    

        public static List<Preguntas> GetPreguntasById(int id) {
            string sqlQuery;
            List<Preguntas> returnEntity;
            sqlQuery="SELECT * FROM Preguntas WHERE IdTemas = @idTemas";

            using (SqlConnection db=new SqlConnection(CONNECTION_STRING)) {
                returnEntity=db.Query<Preguntas>(sqlQuery, new {idTemas=id}).ToList();
            }

            return returnEntity;
        }

        public static List<Respuestas> GetRespuestasById(int id) {
            string sqlQuery;
            List<Respuestas> returnEntity;
            sqlQuery="SELECT * FROM Respuestas WHERE IdPreguntas = @IdPreguntas";

            using (SqlConnection db=new SqlConnection(CONNECTION_STRING)) {
                returnEntity=db.Query<Respuestas>(sqlQuery, new {IdPreguntas=id}).ToList();
            }

            return returnEntity;
        }
    }
    
