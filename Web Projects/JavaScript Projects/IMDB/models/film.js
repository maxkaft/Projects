const Sequelize = require('sequelize');

module.exports = function(sequelize){
    let Film = sequelize.define('Film',{
        id: {
            type: Sequelize.INTEGER,
            primaryKey: true,
            autoIncrement: true,
        },
        name:{
            type: Sequelize.TEXT,
            allowNull: false,
        },
        genre:{
            type: Sequelize.TEXT,
            allowNull: false,
        },
        director:{
            type: Sequelize.TEXT,
            allowNull: false,
        },
        year:{
            type: Sequelize.INTEGER,
            allowNull: false,
        },
    });

    return Film;

};