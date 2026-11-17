DROP TABLE IF EXISTS Course;

CREATE TABLE Course (
    Id         INTEGER PRIMARY KEY AUTOINCREMENT,
    Title      TEXT    NOT NULL,
    Instructor TEXT    NOT NULL,
    Credits    INTEGER NOT NULL CHECK (Credits >= 0),
    Online     INTEGER NOT NULL DEFAULT 0 CHECK (Online IN (0, 1))
);

INSERT INTO Course (Title, Instructor, Credits, Online) VALUES
    ('Programming Fundamentals',                              'Aaron Mitchell',   6, 0),
    ('PC and Office Fundamentals',                            'Marc Leblanc',     1, 0),
    ('CCNA: Introduction to Networks',                        'Priya Nair',       0, 1),
    ('CCNA: Switching, Routing, and Wireless Essentials',     'Priya Nair',       0, 1),
    ('CCNA: Enterprise Networking, Security, Automation',     'Priya Nair',       0, 1),
    ('Academic Writing and Research',                         'Jordan MacDonald', 3, 1),
    ('Applied Writing',                                       'Jordan MacDonald', 3, 1),
    ('Business Communications',                               'Claire Gallant',   3, 1),
    ('Business Fundamentals',                                 'Claire Gallant',   3, 1),
    ('Business Computer Applications I',                      'Dennis Arseneau',  3, 1),
    ('Entrepreneurship',                                      'Dennis Arseneau',  3, 1),
    ('Business Trades Bootcamp',                              'Luc Cormier',      3, 0),
    ('Administrative Math',                                   'Sam Robichaud',    3, 1),
    ('Technical Math for Engineering Technology',             'Sam Robichaud',    3, 1),
    ('Trades Math I',                                         'Luc Cormier',      3, 1),
    ('Work Safely',                                           'Tara Hanscom',     1, 1),
    ('First Aid/CPR Training',                                'Tara Hanscom',     1, 0),
    ('Baking Principles',                                     'Henri Savoie',     6, 0),
    ('Behaviour Interventions',                               'Megan Doucet',     3, 1),
    ('Adaptive and Assistive Technologies',                   'Megan Doucet',     3, 1),
    ('Biology 122',                                           'Owen Fitzpatrick', 3, 1),
    ('Executive Leadership in Policing',                      'Rachel Brewer',    3, 0);
