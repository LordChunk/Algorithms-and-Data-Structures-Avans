class LinkedList
{
    private class Link
    {
        public Link Next;
        public Link Previous;
        public int Value;
    }
    private Link First { get; set; }
    private Link Last { get; set; }
    public bool hasFirst()
    {
        return First != null;
    }
    public void Add(int value)
    {
        Link newLink = new Link
        {
            Next = null,
            Previous = Last,
            Value = value
        };
        Last.Next = newLink;
        Last = newLink;
        if (First == null)
        {
            First = newLink;
        }
    }

    public void AddBeforeLast(int value)
    {
        this.Add(value);
        if (First == Last) return;

        // Giving all objects names based on their "current position"
        var linkThree = Last;
        var linkTwo = linkThree.Previous;
        var linkOne = linkTwo.Previous;

        // Update all next values
        linkOne.Next = linkThree;
        linkTwo.Next = null;
        linkThree.Next = linkTwo;

        // Update all previous values
        linkTwo.Previous = linkThree;
        linkThree.Previous = linkOne;

        Last = linkTwo;
    }

}