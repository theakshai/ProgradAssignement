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
        public ActionResult Index()
        {
            return View(GetDocuments());
        }

        // GET: DocumentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
            return View();
        }

        // POST: DocumentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
