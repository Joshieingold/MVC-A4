DROP TABLE IF EXISTS Course;

CREATE TABLE Course (
    Id         INTEGER PRIMARY KEY AUTOINCREMENT,
    Title      TEXT    NOT NULL,
    Instructor TEXT    NOT NULL,
    Credits    INTEGER NOT NULL CHECK (Credits >= 0),
    Online     INTEGER NOT NULL DEFAULT 0 CHECK (Online IN (0, 1))
);

INSERT INTO Course (Title, Instructor, Credits, Online) VALUES
    ('Written, Interpersonal, and Intrapersonal Skills', 'Mallory Flowers',     3, 1),
    ('Database Design and SQL',                          'Mitchell Boutilier',  5, 0),
    ('Computer Math and Statistics',                     'Chris London',        3, 0),
    ('Responsive Web Design',                            'Chris London',        6, 0),
    ('Operating and File System Concepts',               'Mitchell Boutilier',  0, 0),
    ('Orientation and Community Services',               'Chris Rendell',       0, 0),
    ('Programming Fundamentals',                         'Aaron Mitchell',      6, 0),
    ('Introduction To Source Control',                   'Mitchell Boutilier',  1, 1),
    ('Intermediate SQL for Developers',                  'Mitchell Boutilier',  3, 0),
    ('Ethics for Computing Professionals',               'Mallory Flowers',     0, 1),
    ('Command Line Interface: Bash',                     'Chris Rendell',       3, 0),
    ('Object Oriented Programming',                      'Aaron Mitchell',      6, 0),
    ('JavaScript Programming',                           'Stephen Monk',        3, 0),
    ('Database Programming',                             'Aaron Mitchell',      3, 0),
    ('Work Safely',                                      'Self-Directed',       0, 1),
    ('Software Engineering',                             'Chris London',        6, 0),
    ('Employment Readiness',                             'Mitchell Boutilier',  2, 0),
    ('Advanced JavaScript',                              'Stephen Monk',        3, 0),
    ('Server-Side Web: MVC Framework',                   'Stephen Monk',        6, 0),
    ('PHP',                                              'Mitchell Boutilier',  3, 0),
    ('Enterprise Java',                                  'Chris Rendell',       6, 0),
    ('Quality Assurance Testing',                        'Rositsa Shvorak',     2, 1),
    ('Amazon Web Services',                              'Aaron Mitchell',      2, 1);
