# Cover Letter Generator v1.0
Cover Letter Generator is a piece of software I wrote to help manage and create new cover letters for job applications, meetings, and proposals. The software works by taking pieces of information created and inserted by the user through external files and using PDF API iTextSharp to generate a document.

## properties.cfg
The properties configuration file holds the majority of information to be used in the heading of the cover letter document. This includes your name, address, phone number, intro and outro text, etc. Software has no online capability, and does not store any of this information locally or on any cloud-based server.

## letter.txt
This hosts the body of text that will be your cover letter. Every new line signifies a new indented paragraph. Certain syntax must be used to properly include user-given information into the body.

## letter.txt Syntax
Within the letter.txt file, certain syntax is used to inject user-information into your letter body. "$C" is used to insert the company name, and "$P" is used to insert the position. Other syntax is planned for implementation in the future.

Future releases are planned to implement font choices, color choices, specific margin-tweaking and more.
