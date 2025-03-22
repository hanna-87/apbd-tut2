using Tutorial2.Collections.Data;

namespace Tutorial2.Collections;

public class Collections
{
    public static List<StudentResult> ProcessGrades(List<Student> students)
    {
        var studentResults = new List<StudentResult>();
        foreach (var st in students)
        { 
            var res  = new StudentResult();
            res.Name = st.Name;
            if (st.Grade >= 90)
            {
                res.Result = "Exemption";
                
            }else if (st.Grade >= 50)
            {
                res.Result = "Passing";
            }else if (st.Grade < 50)
            {
                res.Result = "Needs Improvement";
            }
            studentResults.Add(res);
        }
        return studentResults;
    }
}