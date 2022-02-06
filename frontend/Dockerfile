FROM node:16.13-alpine3.15 AS builder

WORKDIR /app
COPY package.json .
COPY package-lock.json .
RUN npm install

COPY . .

RUN npm run build

FROM nginx:1.21.6-alpine AS server
COPY --from=builder /app/build /usr/share/nginx/html
EXPOSE 80