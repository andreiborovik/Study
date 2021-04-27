namespace CodeFirst2
{
    class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }

        public int ProductId { get; set; }
        public Product Product;
    }
}
