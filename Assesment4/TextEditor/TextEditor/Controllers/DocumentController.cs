using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using TextEditor.Models;

namespace TextEditor.Controllers
{
    public class DocumentController : Controller
    {

        public IConfiguration _configuration;
        public SqlConnection _connection;
        public DocumentController(IConfiguration _configuration)
        {
            this._configuration = _configuration;
                this._connection = new SqlConnection(_configuration.GetConnectionString("DOCUMENT_DB"));
        }

        public List<Document> GetDocuments()
        {
            List<Document> docs = new ();
            SqlCommand command = new ("select * from Document_Info", _connection);
            _connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Document document = new()
                {
                    Id = (int)reader["id"],
                    UserId = (int)reader["UserId"],
                    Title = (string)reader["Title"],
                    Content = (string)reader["Content"]
                };
                docs.Add(document);

            }
            reader.Close();
            _connection.Close();
            return docs;
        }
        // GET: DocumentController

        public Document GetDocumentById(int id)
        {
            SqlCommand command = new($"select * from Document_Info where id = {id}", _connection);
            _connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Document document = new();

            while (reader.Read())
            {
                    document.Id = (int)reader["id"];
                    document.UserId = (int)reader["UserId"];
                    document.Title = (string)reader["Title"];
                document.Content = (string)reader["Content"];

            }
            reader.Close();
            _connection.Close();
            return document;
            
        }
        public ActionResult Index()
        {
            return View(GetDocuments());
        }

        // GET: DocumentController/Details/5
        public ActionResult Details(int id)
        {
            return View(GetDocumentById(id));
        }

        public void InsertDocument(Document document)
        {
            _connection.Open();
            SqlCommand command = new("insert into Document_Info values @document.UserId, @document.Title, @document.Content", _connection);
            command.ExecuteNonQuery();
            _connection.Close();

        }
        // GET: DocumentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DocumentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DocumentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DocumentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DocumentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(GetDocumentById(id));
        }

        // POST: DocumentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,Document document)
        {
            try
            {
                _connection.Open();
                SqlCommand command = new($"delete from Document_Info where id = {id}", _connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                _connection.Close();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
