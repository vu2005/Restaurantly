INSERT INTO roles (role_name) VALUES
('Admin'),
('Manager'),
('Customer'),
('Staff');
INSERT INTO categories (name, sort_order) VALUES
('Starters', 1),
('Main Course', 2),
('Desserts', 3),
('Drinks', 4);
INSERT INTO BookTable (FullName, Email, Phone, NumberOfGuests, ReservationDate, ReservationTime, Message, IsConfirmed) VALUES
('John Doe', 'john@example.com', '123456789', 4, '2024-11-01', '18:30:00', 'Looking forward to it!', TRUE),
('Jane Smith', 'jane@example.com', '987654321', 2, '2024-11-02', '19:00:00', 'Birthday celebration', FALSE);
INSERT INTO customers (full_name, email, phone, password, reset_token, reset_token_expiry, status, date_added) VALUES
('John Doe', 'john@example.com', '123456789', 'hashed_password_1', NULL, NULL, TRUE, NOW()),
('Jane Smith', 'jane@example.com', '987654321', 'hashed_password_2', 'MxDAai3K', '2024-12-01 12:00:00', TRUE, NOW());
INSERT INTO tables (table_number, seats, status) VALUES
(1, 4, TRUE),
(2, 2, TRUE),
(3, 6, FALSE);
INSERT INTO reservations (customer_id, table_id, number_of_guests, reservation_time, status, date_added, date_modified) VALUES
(1, 1, 4, '2024-11-01 18:30:00', TRUE, NOW(), NOW()),
(2, 2, 2, '2024-11-02 19:00:00', FALSE, NOW(), NOW());
INSERT INTO products (name, category_id, price, description, featured, image, status, date_added, date_modified) VALUES
('Caesar Salad', 2, 8.99, 'Crispy romaine lettuce with Caesar dressing', TRUE, 'greek-salad.jpg', TRUE, NOW(), NOW()),
('Grilled Chicken', 2, 12.99, 'Tender chicken grilled to perfection', TRUE, 'tuscan-grilled.jpg', TRUE, NOW(), NOW());
INSERT INTO orders (customer_id, reservation_id, total, status, payment_status, date_added, date_modified) VALUES
(1, 1, 50.00, TRUE, TRUE, NOW(), NOW()),
(2, 2, 30.00, FALSE, FALSE, NOW(), NOW());
INSERT INTO order_items (order_id, product_id, quantity, price) VALUES
(1, 1, 2, 8.99),
(1, 2, 1, 12.99),
(2, 1, 1, 8.99);
INSERT INTO product_images (product_id, image, sort_order) VALUES
(1, 'caesar_salad.jpg', 1),
(2, 'grilled_chicken.jpg', 1);
INSERT INTO users (username, password, email, role_id, status, created_at) VALUES
('admin', 'hashed_admin_password', 'admin@example.com', 1, TRUE, NOW()),
('manager', 'hashed_manager_password', 'manager@example.com', 2, TRUE, NOW());
INSERT INTO settings (`key`, value) VALUES
('site_name', 'Restaurantly'),
('site_email', 'info@restaurantly.com');
INSERT INTO contacts (full_name, email, phone, subject, message, date_added, date_modified, status) VALUES
('John Doe', 'john@example.com', '123456789', 'Reservation Inquiry', 'Can I change my reservation?', NOW(), NOW(), TRUE),
('Jane Smith', 'jane@example.com', '987654321', 'Menu Question', 'Do you have vegan options?', NOW(), NOW(), FALSE);
INSERT INTO banner_images (image, link, sort_order, status) VALUES
('banner1.jpg', 'https://example.com', 1, TRUE),
('banner2.jpg', 'https://example.com', 2, TRUE);
INSERT INTO category_paths (category_id, path_id, level) VALUES
(1, 1, 0),
(2, 2, 0);
INSERT INTO reviews (customer_id, product_id, rating, comment, date_added) VALUES
(1, 1, 5, 'The best Caesar Salad I have ever had!', NOW()),
(2, 2, 4, 'Grilled Chicken was tasty but a bit dry.', NOW());
