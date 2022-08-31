# WISHLIST

This repository describes Wishlist API

## User stories

1. As a user I want to create empty wishlist so that I can add presents I want to the list
2. As a user I want to add/remove presents to certain list so that I can fill wishlist with presents
3. As a user I want to share my wishlist with friends so that they can book some present for me
4. As a user I want to book/unbook present in certain wishlist
5. As a user I want to be sure one present can be booked only once so that I won't receive one present twice

## Term

- wishlist - collection of related presents
- present - item inside wishlist

## HTTP API

- PUT /api/wishlist -> Returns 201 with withslist ID
- PUT /api/present BODY=present details + wishlist id -> Returns 204 No content / 400 Bad Request if no such wishlist
- DELETE /api/present/{presentId} -> Returns 204 No content
- GET /api/wishlist/{wishlistId} -> Returns 200 OK / 404 Not Found if no such wishlist
- POST /api/present/{presentId} BODY=book/unbook -> Returns 200 OK / 400 Bad Request if can't be booked/unbooked / 404 Not Found if no such present

## Models

### class Wishlist

- id
- name
- createdDate
- presents

### class Present

- id
- name
- comment
- wishlist
- createdDate
- bookedAt
