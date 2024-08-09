using System;
using System.Text;

namespace String_Builder.Entities

{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        //Como um post terá vários comentários, devemos então passar os comentários como lista
        public List<Comment> Comments { get; set; } = new List<Comment>(); //Garante a instânciação da lista

        public Post() { }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        //Se ficarmos sempre a concatenar strings, teremos um procedimento muito demorado, tanto pessoal quando de dinamismo do software
        //Contorna-se isso utilizando o String builder
        public override string ToString()
        {   //A partir deste operador podemos montar um texto a partir dele
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);//Adicionau um texto no final
            sb.Append(Likes); //Adiciona texto com quebra de linha no final
            sb.Append(" Likes - ");
            sb.Append(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append(Content);
            sb.Append(Comments);

            //para cada comentario c, na minha linsta de comentários
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
