using LearningManagementSystem.Constans;
using Npgsql;

namespace LearningManagementSystem.Repositories;

public abstract class BaseRepository
{
    protected readonly NpgsqlConnection _connection;

    public BaseRepository()
    {
        _connection = new NpgsqlConnection(db_Constans.DB_CONNECTIONSTRING);
    }
}
