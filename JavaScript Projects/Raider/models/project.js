const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    let Project = sequelize.define('Project', {
        title:{
            type: Sequelize.TEXT,
            allowNull: false,
        },
        description:{
            type: Sequelize.TEXT,
            allowNull: false,
        },
        budget:{
            type: Sequelize.INTEGER,
            allowNull: false,
        }

    });
    return Project;
};