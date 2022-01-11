FROM node:16.13-alpine3.15

EXPOSE 3000

WORKDIR /usr/app
COPY package.json .
COPY package-lock.json .
RUN npm install

COPY . .

ENTRYPOINT [ "npm", "start" ]