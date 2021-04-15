namespace AutoPractice9 
{ 
    public class Page
    {
        public string Title { get; set; }
        public int width = 600;
        public FieldClass Field { get; set; }
        public int[] elements;
        public bool IsInitiated { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public Page(string title)
        {
            Title = title;
            elements = new int[2] { 1, 2};
            Field = new Page.FieldClass();
            Description = "This is description.";
            Email = "some@email2";
        }

        public class FieldClass { 
        }
    }
}
