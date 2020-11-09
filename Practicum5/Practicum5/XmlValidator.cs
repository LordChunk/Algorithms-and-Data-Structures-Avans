
namespace Alg1.Practica.Practicum5
{
    public class XmlValidator
    {
        public bool Validate(string xml)
        {
            if (xml == null)
                return true;

            var tags = new Stack();
            var readingTag = false;
            var tagName = "";

            foreach (var character in xml)
            {
                if (character == '<')
                {
                    // Check if a tag was never closed
                    if (readingTag)
                        return false;
                    readingTag = true;
                } else if (character == '>')
                {
                    // Check if tag was opened
                    if (!readingTag)
                        return false;

                    // Check if tag was closing or opening tag
                    // Closing a closing tags
                    if (tagName.StartsWith("/"))
                    {
                        tagName = tagName.TrimStart('/');

                        // Check if a valid tag was closed
                        if (tagName == tags.Peek())
                            tags.Pop();
                        else
                            return false;
                    }
                    else // Closing an opening tag
                        tags.Push(tagName);

                    tagName = "";
                    readingTag = false;
                } else if (character == ' ' && readingTag)
                    return false;
                else if(readingTag)
                    tagName += character;
            }

            return tags.IsEmpty();
        }
    }
}


