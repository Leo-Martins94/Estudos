package usecase

import (
	"github.com/Leo-Martins94/gointensivo/internal/order/entity"
	"github.com/stretchr/testify/suite"
)

type CalculateFinalPriceUseCaseTestSuit struct {
	suite.Suite
	OrderRepository entity.OrderRepositoryInterface
}
