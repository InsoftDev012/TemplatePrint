﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace TemplatePrint.Models
{
    using System.Collections.Generic;
    using TemplatePrint.Models;
    using Newtonsoft.Json.Serialization;
    using Newtonsoft.Json.Linq;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "I:\TemplatePrint\Template\SchoolReportTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class SchoolReportTemplate : SchoolReportTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"<!doctype html>
<html lang=""en"">
  <head>
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">

    <title>Hello, world!</title>

<style>
.tablefirst, .tablesecond {
    text-align: center;
}
@@media print {
		body {
			-webkit-print-color-adjust: exact;
		}
	}

.marksheet-box{
    background-image: url(http://peoplehelp.in/mewaruni/images/marksheet-bg.png);
    border: 2px solid red;
    padding: 15px;
    margin-top: 20px;
    background-repeat: no-repeat;
    background-position: center center;
  background-size: contain;
  page-break-after: always;
}
.uni-logo, .uni-add, .txt-cntr{
  text-align: center;
}
.uni-add p {
    width: ;
    margin: 10px auto;
}
.Studen_Detail {
    margin: 20px 0;
}
.Studen_Detail p {
    margin-bottom: 0px;
}
hr {
    margin-top: 1rem;
    margin-bottom: 1rem;
    border: 0;
    border-top: 1px solid rgba(0, 0, 0, 0.32);
}
* {
    border-color: red !important;
}
.table-div thead th {
    border-bottom: 0px !important;
}
</style>

  </head>
  <body onload=""window.print()"">
    ");
            
            #line 70 "I:\TemplatePrint\Template\SchoolReportTemplate.tt"

    // Iterate over each report in the list of reports
    foreach (var report in _reports)
    {

            
            #line default
            #line hidden
            this.Write("\r\n<section>\r\n\t<div class=\"container-fluid\">\r\n\t\t<div class=\"row\">\r\n\t\t\t<div class=\"" +
                    "col-12\">\r\n\t\t\t\t<div class=\"marksheet-box\">\r\n\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t<div cl" +
                    "ass=\"col-sm-3 txt-cntr\"></div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6 uni-logo\">\r\n\t\t\t\t\t\t\t<i" +
                    "mg src=\"http://peoplehelp.in/mewaruni/images/mewaruniversitylogo.png\" alt=\"uni-l" +
                    "ogo\"/>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-3 txt-cntr\"></div>\r\n\t\t\t\t\t\t<div cl" +
                    "ass=\"col-sm-12 uni-add\">\r\n\t\t\t\t\t\t\t<p>Address: NH - 79 Gangrar, Chittorgarh, Rajas" +
                    "than-312901 <br>(www.mewaruniversity.org)</p>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<" +
                    "hr>\r\n\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t<div class=\"col-sm-4 enrolmentNo txt-cntr\">\r\n" +
                    "\t\t\t\t\t\t\t<p><strong>Enrollment No. </strong> ABCD00012345</p>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t" +
                    "\t<div class=\"col-sm-4 streamName  txt-cntr\">\r\n\t\t\t\t\t\t\t<h2>RESULT</h2>\r\n\t\t\t\t\t\t\t<h5" +
                    ">Bachelor of Commerce (General)<h5>\r\n\t\t\t\t\t\t\t<h5>Year Examination : May - 19<h5>\r" +
                    "\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<di" +
                    "v class=\"row Studen_Detail\">\r\n\t\t\t\t\t\t<div class=\"container\">\r\n\t\t\t\t\t\t\t<div class=\"" +
                    "row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4 offset-sm-2\">\r\n\t\t\t\t\t\t\t\t\t<p><span><strong>Nam" +
                    "e of Student :</strong></span><strong> Sunny Sharma</strong></p>\r\n\t\t\t\t\t\t\t\t\t<p><s" +
                    "trong>Fathers Name :</strong><strong> Vinod Sharma</strong></p>\r\n\t\t\t\t\t\t\t\t\t<p><st" +
                    "rong>Mothers Name :</strong><strong> Saroj Sharma</strong></p>\r\n\t\t\t\t\t\t\t\t</div>\r\n" +
                    "\t\t\t\t\t\t\t\t<div class=\"col-sm-4 offset-sm-2\">\r\n\t\t\t\t\t\t\t\t\t<p><strong>Roll No :</stron" +
                    "g><strong> 1234567890</strong></p>\r\n\t\t\t\t\t\t\t\t\t<p><strong>Year :</strong><strong> " +
                    "2019</strong></p>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t" +
                    "\t\r\n\t\t\t\t\r\n\t\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"container-fluid\">\r\n\t\t\t\t<div clas" +
                    "s=\"col-12\">\r\n<div class=\"table-div\">\r\n<table class=\"table table-bordered tablefi" +
                    "rst\">\r\n  <thead>\r\n    <tr>\r\n      <th rowspan=\"2\" style=\"vertical-align: middle;" +
                    "\">Subject Code</th>\r\n      <th rowspan=\"2\" style=\"vertical-align: middle;\">Subje" +
                    "ct Name</th>\r\n      <th colspan=\"2\">Maximum Marks</th>\r\n      <th rowspan=\"2\" st" +
                    "yle=\"vertical-align: middle;\">Total</th>\r\n      <th colspan=\"2\">Marks Obtained</" +
                    "th>\r\n      <th rowspan=\"2\" style=\"vertical-align: middle;\">Total</th>\r\n      <th" +
                    " rowspan=\"2\" colspan=\"3\" style=\"vertical-align: middle;\">Result</th>\r\n    </tr>\r" +
                    "\n    <tr>\r\n      <th rowspan=\"1\">Internal</th>\r\n      <th rowspan=\"1\">External</" +
                    "th>\r\n      <th rowspan=\"1\">Internal</th>\r\n      <th rowspan=\"1\">External</th>\r\n " +
                    "   </tr>\r\n  </thead>\r\n  <tbody>\r\n    <tr>\r\n      <th>abc</th>\r\n      <td style=\"" +
                    "text-align:left;\">Subject Name</td>\r\n      <td>40</td>\r\n      <td>60</td>\r\n     " +
                    " <td>100</td>\r\n      <td>20</td>\r\n      <td>30</td>\r\n      <td>50</td>\r\n      <t" +
                    "d colspan=\"2\">Pass</td>\r\n    </tr>\r\n    <tr>\r\n      <th>def</th>\r\n      <td styl" +
                    "e=\"text-align:left;\">Subject Name</td>\r\n      <td>40</td>\r\n      <td>60</td>\r\n  " +
                    "    <td>100</td>\r\n      <td>20</td>\r\n      <td>30</td>\r\n      <td>50</td>\r\n     " +
                    " <td colspan=\"2\">Pass</td>\r\n    </tr>\r\n    <tr>\r\n      <th>ghi</th>\r\n      <td s" +
                    "tyle=\"text-align:left;\">Subject Name</td>\r\n      <td>40</td>\r\n      <td>60</td>\r" +
                    "\n      <td>100</td>\r\n      <td>20</td>\r\n      <td>30</td>\r\n      <td>50</td>\r\n  " +
                    "    <td colspan=\"2\">Pass</td>\r\n    </tr>\r\n    <tr>\r\n      <th>jkl</th>\r\n      <t" +
                    "d style=\"text-align:left;\">Subject Name</td>\r\n      <td>40</td>\r\n      <td>60</t" +
                    "d>\r\n      <td>100</td>\r\n      <td>20</td>\r\n      <td>30</td>\r\n      <td>50</td>\r" +
                    "\n      <td colspan=\"2\">Pass</td>\r\n    </tr>\r\n    <tr>\r\n      <th>mno</th>\r\n     " +
                    " <td style=\"text-align:left;\">Subject Name</td>\r\n      <td>40</td>\r\n      <td>60" +
                    "</td>\r\n      <td>100</td>\r\n      <td>20</td>\r\n      <td>30</td>\r\n      <td>50</t" +
                    "d>\r\n      <td colspan=\"2\">Pass</td>\r\n    </tr>\r\n    <tr>\r\n      <th colspan=\"2\" " +
                    "style=\"text-align: right;\">Total</th>\r\n      <th>200</th>\r\n      <th>300</th>\r\n " +
                    "     <th>500</th>\r\n      <th>100</th>\r\n      <th>150</th>\r\n      <th>250</th>\r\n " +
                    "     <th>Remarks</th>\r\n      <th>50%</th>\r\n    </tr>\r\n  </tbody>\r\n  \r\n  \r\n<table" +
                    " class=\"table table-bordered tablesecond\">\r\n  <thead>\r\n    <tr>\r\n      <th>Year<" +
                    "/th>\r\n      <th>First Year</th>\r\n      <th>Second Year</th>\r\n      <th>Third Yea" +
                    "r</th>\r\n      <th>Grand Total</th>\r\n      <th>Percentage</th>\r\n      <th>Result<" +
                    "/th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n    <tr>\r\n      <th>Max Marks</th>\r\n    " +
                    "  <td>40</td>\r\n      <td>60</td>\r\n      <td>100</td>\r\n      <td>20</td>\r\n      <" +
                    "td>30</td>\r\n      <td>50</td>\r\n    </tr>\r\n    <tr>\r\n      <th>Total Marks</th>\r\n" +
                    "      <td>40</td>\r\n      <td>60</td>\r\n      <td>100</td>\r\n      <td>20</td>\r\n   " +
                    "   <td>30</td>\r\n      <td>50</td>\r\n    </tr>\r\n  </tbody>\r\n</table>\r\n  \r\n        " +
                    "    </div>\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t\r\n\t\t\t\t\r\n\t\t\t\t\r\n\t\t\t\t</div>\r\n\t\t\t\t<br><br><b" +
                    "r><br>\r\n<div class=\"row\">\r\n\t<div class=\"col-sm-4 txt-cntr\"><p style=\"height:40px" +
                    ";\"></p>\r\n    <p><strong>Date of Issue :</strong><strong> 11 June 2019</strong></" +
                    "p></div>\r\n\t<div class=\"col-sm-4 txt-cntr\"><p style=\"height:40px;\"></p>\r\n    <p><" +
                    "strong>University Stamp </strong></p></div>\r\n\t<div class=\"col-sm-4 txt-cntr\"><p>" +
                    "<img src=\"http://peoplehelp.in/mewaruni/images/signature.png\" alt=\"student-signa" +
                    "rute\" width=\"100px; height=\"40px;\"/></p><p><strong>Signature of Controller</stro" +
                    "ng></p></div>\r\n</div>\r\n\t\t\t\t\r\n\t\t\t\t\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\t\r\n\r\n</div>\r\n\r\n" +
                    "\r\n  \r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    \r\n" +
                    "    \r\n  \r\n");
            
            #line 280 "I:\TemplatePrint\Template\SchoolReportTemplate.tt"
 } // End of foreach report 
            
            #line default
            #line hidden
            this.Write(@"    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
  </body>
</html>


");
            return this.GenerationEnvironment.ToString();
        }
        private global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost hostValue;
        /// <summary>
        /// The current host for the text templating engine
        /// </summary>
        public virtual global::Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost Host
        {
            get
            {
                return this.hostValue;
            }
            set
            {
                this.hostValue = value;
            }
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public class SchoolReportTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        public System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
