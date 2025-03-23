public class QueryBuilder
{
    private string _selectClause = "";
    private string _fromClause = "";
    private string _whereClause = "";
    private string _orderByClause = "";

    public QueryBuilder Select(string fields)
    {
        _selectClause = "SELECT " + fields;
        return this;
    }

    public QueryBuilder From(string table)
    {
        _fromClause = "FROM " + table;
        return this;
    }

    public QueryBuilder Where(string condition)
    {
        _whereClause = "WHERE " + condition;
        return this;
    }

    public QueryBuilder OrderBy(string orderBy)
    {
        _orderByClause = "ORDER BY " + orderBy;
        return this;
    }

    public string Build()
    {
        if (string.IsNullOrWhiteSpace(_selectClause) || _selectClause == "SELECT " ||
        string.IsNullOrWhiteSpace(_fromClause) || _fromClause == "FROM ")
        {
            throw new InvalidOperationException("A valid SQL query must have at least SELECT and FROM clauses.");
        }

        string query = $"{_selectClause} {_fromClause}";

        if (!string.IsNullOrWhiteSpace(_whereClause))
        {
            query += $" {_whereClause}";
        }

        if (!string.IsNullOrWhiteSpace(_orderByClause))
        {
            query += $" {_orderByClause}";
        }

        if (!query.EndsWith(";"))
        {
            query += ";";
        }

        return query;
    }


    public void Reset()
    {
        _selectClause = "";
        _fromClause = "";
        _whereClause = "";
        _orderByClause = "";
    }
}
