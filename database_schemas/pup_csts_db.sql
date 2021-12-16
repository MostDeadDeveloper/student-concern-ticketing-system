/* +++ user_t notes +++
	-isAdmin and isAgent are set to boolean to separate an entity(user) based on its role
    -isAdmin && isAgent leading to BOOL value FALSE means it is a customer
*/
CREATE TABLE user_t 
	(id INT NOT NULL,
	 isAdmin BOOLEAN,
     isAgent BOOLEAN, 
	 CONSTRAINT userID_OT_pk PRIMARY KEY (id));

/* +++ categoryID_t notes +++ 
	-Devs must set a number code system for all of the IDs for readability and convenience purposes 
		since all of the IDs will be set to INT (for now, i guess)
*/
CREATE TABLE category_t
	(id INT, 
     ctgrName VARCHAR(15),
     ctgrDescription TEXT, 
     CONSTRAINT category_OT_pk PRIMARY KEY (id)); 

/* +++ userUnderCategory_t notes +++ 
	- created for the collection of users under the same category for report 
    - Can be used for department report: 
			- Each category has a designated staff
	- Can be used for User Volume report: 
			- Each category may have a number of customers with the same ticket issue
*/

CREATE TABLE userUnderCategory_t
	(ctgrID INT, 
     userID INT, 
     CONSTRAINT ctgrID_ON_userUndeCategory_fk FOREIGN KEY (ctgrID) REFERENCES category_t(id),
     CONSTRAINT userID_ON_userUnderCategory_fk FOREIGN KEY (userID) REFERENCES user_t(id));


/* +++ ticketStatus_t notes +++
		- created for the status of customer ticket
        - Possible status values for respective ID: 
			done: 
			ongoing: 
            discontinued: 
            new:
*/
CREATE TABLE ticketStatus_t 
	(id INT, 
     statusName VARCHAR(15),
     CONSTRAINT ticketStatus_OT_pk PRIMARY KEY (id));
     
/* +++ ticketPriorities_t notes
	- [OPTIONAL] created for priority feature of each ticket 
    - possible values for priority:
		1 - HIGH PRIORITY 
        2 - MEDIUM PRIOTITY 
        3 - LOW PRIORITY 
*/

CREATE TABLE ticketPriorities_t
	(id INT, 
	 priorityName VARCHAR(15),
     numberCode INT,
     CONSTRAINT ticketPriorities_OT_pk PRIMARY KEY (id));


/* +++ ticket_t notes +++ 
	- created for the ticket that will be using in the system 
    - I am not sure if priority list would help the admin/agent but we can just removed it if it is proven unnecessary
    
*/


CREATE TABLE ticket_t 
	(id BIGINT NOT NULL AUTO_INCREMENT, 
     userID INT,
     agentID INT,
     categoryID INT,
     statusID INT,
     priorityID INT,
     tcktSubject VARCHAR(20),
     tcktContent TEXT, 
     createdAt DATETIME,
     updatedAt DATETIME, 
     completedAT TIMESTAMP,
     CONSTRAINT ticketID_OT_pk PRIMARY KEY (id),
     CONSTRAINT userID_ON_ticket_fk FOREIGN KEY (userID) REFERENCES user_t(id),
     CONSTRAINT agentID_ON_ticket_fk FOREIGN KEY (agentID) REFERENCES user_t(id),
     CONSTRAINT categoryID_ON_ticket_fk FOREIGN KEY (categoryID) REFERENCES category_t(id),
     CONSTRAINT statusID_ON_ticket_fk FOREIGN KEY (statusID) REFERENCES ticketStatus_t(id),
     CONSTRAINT priorityID_ON_ticket_fk FOREIGN KEY (priorityID) REFERENCES ticketPriorities_t(id)); 
   

/* +++ comments_t notes +++
	- created for collaboration feature of the system where users can leave a comment on each ticket for discussion 
    - I am not sure for the exact structure of a comment but I just made my general idea for this one. 
*/

CREATE TABLE comment_t
	(id BIGINT, 
     userName VARCHAR(50),
     content LONGTEXT,
     userID INT,
     ticketID BIGINT,
     CONSTRAINT comment_OT_pk PRIMARY KEY (id),
     CONSTRAINT userID_ON_comment_fk FOREIGN KEY (userID) REFERENCES user_t(id),
     CONSTRAINT ticketID_ON_comment_fk FOREIGN KEY (ticketID) REFERENCES ticket_t(id));
     
/* +++ ticketAudit_logs_t +++ 
	- created for auditing all actions/operation taken to the respective key
    - ACCESS should only be allowed for admin and agents only
*/
CREATE TABLE ticketAudit_logs_t
	(id BIGINT NOT NULL, 
	 ticketAction LONGTEXT, 
     userID INT,
     ticketID BIGINT,
     createdAt DATETIME,
     updatedAT DATETIME,
     CONSTRAINT ticketAudit_logs_OT_pk PRIMARY KEY (id),
     CONSTRAINT userID_ON_ticketAudit_logs_fk FOREIGN KEY (userID) REFERENCES user_t(id),
     CONSTRAINT ticketID_ON_ticketAudit_logs_fk FOREIGN KEY (ticketID) REFERENCES ticket_t(id));
     
	