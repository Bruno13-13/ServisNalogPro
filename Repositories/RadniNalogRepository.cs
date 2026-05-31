using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ServisNalogPro.Models;

namespace ServisNalogPro.Repositories
{
    public class RadniNalogRepository
    {
        public void Spremi(RadniNalog nalog)
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                connection.Open();

                string query = @"INSERT INTO RadniNalog
                                (OpisKvara, Datum, Status, IdZaposlenika)
                                VALUES (@OpisKvara, @Datum, @Status, @IdZaposlenika)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OpisKvara", nalog.OpisKvara);
                    command.Parameters.AddWithValue("@Datum", nalog.Datum);
                    command.Parameters.AddWithValue("@Status", nalog.Status);
                    command.Parameters.AddWithValue("@IdZaposlenika", nalog.IdZaposlenika);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void Obrisi(int idNaloga)
        {
            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                connection.Open();
                string query = "DELETE FROM RadniNalog WHERE IdNaloga = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", idNaloga);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
