using ScoreboardAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ScoreboardAPI.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
   


        WebApiContext db = new WebApiContext();
        //Tum kullanicilari liste olarak getirmek.
        // GET api/user
        [HttpGet]
        [Route("all")]
        public IEnumerable<user> Get()
        {
            return db.user.ToList();
        }

        /*
        * Zorluk derecesine gore kullanicilari getirmek.
        * GET api/user/difficulty/1
        *
        */
        [HttpGet]
        [Route("difficulty/{dif}")]
        public IEnumerable<user> Get(int dif)
        {
            return db.user.Where(x => x.difficulty==dif).OrderBy(a=>a.score).Take(10).ToList();
        }

        /*
        * Yeni kullaniciyi kayit etmek.
        * Basariyla tamamlanan her oyundan sonra Post yapilir.
        * POST api/user/add?...
        *
        */
        [HttpPost]
        [Route("add")]
        public HttpResponseMessage Add(user post_user)
        {
            db.user.Add(new user() { userID = post_user.userID, score = post_user.score, difficulty = post_user.difficulty, date = System.DateTime.Today});
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.Created, "Basarıyla kayıt edildi.");
        }

        // PUT api/user/5
        public void Put(int id, [FromBody]string value)
        {
        }

    }
}
